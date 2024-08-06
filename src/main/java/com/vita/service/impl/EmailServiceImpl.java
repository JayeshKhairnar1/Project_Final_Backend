package com.vita.service.impl;

import java.io.File;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.mail.SimpleMailMessage;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.mail.javamail.MimeMessageHelper;
import org.springframework.stereotype.Service;

import com.vita.model.User;
import com.vita.repositoty.UserRepository;
import com.vita.service.EmailService;

import jakarta.mail.internet.MimeMessage;

@Service
public class EmailServiceImpl implements EmailService {

    @Autowired
    private JavaMailSender javaMailSender;

    @Autowired
    private UserRepository userRepo;

    @Value("${spring.mail.username}")
    private String fromEmailId;

    @Override
    public String loginEmail(String toEmailId, String subject, String body) {
        User user = userRepo.findByEmail(toEmailId);
        if (user == null) {
            return "User not found for email: " + toEmailId;
        }

        String emailBody = body + "\n\nUser ID: " + user.getUserid() + "\nPassword: " + user.getPassword();

        SimpleMailMessage smm = new SimpleMailMessage();
        smm.setFrom(fromEmailId);
        smm.setTo(user.getEmail());
        smm.setSubject(subject);
        smm.setText(emailBody);

        javaMailSender.send(smm);

        return "Email sent successfully";
    }


    
    @Override
	public String invoiceEmail(String toEmailId, String subject, String body) {

		MimeMessage mimeMessage = javaMailSender.createMimeMessage();
		MimeMessageHelper helper;
		try {
			helper = new MimeMessageHelper(mimeMessage, true);
			helper.setTo(toEmailId);
			helper.setSubject(subject);
			helper.setText(body);
			File attachment = new File("C:/Users/Lenovo/Downloads/invoice.pdf");
			if (attachment != null && attachment.exists()) 
			{
				helper.addAttachment(attachment.getName(), attachment);
			}
		} 
		catch (Exception e) 
		{
			return "Error in sending mail";
		}

		javaMailSender.send(mimeMessage);

		return "Invoice email sent successfully";
	}
}
