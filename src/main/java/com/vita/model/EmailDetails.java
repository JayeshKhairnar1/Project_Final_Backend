package com.vita.model;

public class EmailDetails {

    private String sendTo;
    private String invoiceName;
	public String getSendTo() {
		return sendTo;
	}
	public void setSendTo(String sendTo) {
		this.sendTo = sendTo;
	}
	public String getInvoiceName() {
		return invoiceName;
	}
	public void setInvoiceName(String invoiceName) {
		this.invoiceName = invoiceName;
	}
	public EmailDetails(String sendTo, String invoiceName) {
		super();
		this.sendTo = sendTo;
		this.invoiceName = invoiceName;
	}
	public EmailDetails() {
		super();
	}
}
