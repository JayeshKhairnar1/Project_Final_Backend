package com.vita.model;

public class EmailDetails {

    private String sendTo;

    // Default constructor
    public EmailDetails() {}

    // Parameterized constructor
    public EmailDetails(String sendTo) {
        this.sendTo = sendTo;
    }

    public String getSendTo() {
        return sendTo;
    }

    public void setSendTo(String sendTo) {
        this.sendTo = sendTo;
    }
}
