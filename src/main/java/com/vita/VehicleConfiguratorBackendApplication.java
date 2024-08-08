package com.vita;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class VehicleConfiguratorBackendApplication {

	public static void main(String[] args) {
		//SpringApplication.run(VehicleConfiguratorBackendApplication.class, args);
		
		//  set a your profile programmatically
		
	        SpringApplication app = new SpringApplication(VehicleConfiguratorBackendApplication.class);
	        app.setAdditionalProfiles("jayesh");
	        app.run(args);
	   
	}

}
