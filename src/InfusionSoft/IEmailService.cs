//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfusionSoft
{
    using System;
    using System.Collections.Generic;
    
    
    public interface IEmailService : InfusionSoft.IService
    {
        
        int AddEmailTemplate(string pieceTitle, string categories, string toAddress, string ccAddress, string bccAddress, string subject, string textBody, string htmlBody, string contentType, string mergeContext);
        
        bool AttachEmail(int contactId, string fromName, string fromAddress, string toAddress, string ccAddresses, string bccAddresses, string contentType, string subject, string htmlBody, string textBody, string header, string receivedDate, string sentDate, int emailSentType);
        
        string[] GetAvailableMergeFields(string mergeContext);
        
        InfusionSoft.Definition.EmailTemplate GetEmailTemplate(int templateId);
        
        int GetOptStatus(string email);
        
        bool OptIn(string email, string optInReason);
        
        bool OptOut(string email, string optOutreason);
        
        bool SendEmail(int[] contactList, string fromAddress, string toAddress, string ccAddresses, string bccAddresses, string contentType, string subject, string htmlBody, string textBody, int templateId);
        
        bool SendTemplate(int[] contactList, string templateId);
        
        bool UpdateEmailTemplate(int templateId, string pieceTitle, string category, string fromAddress, string toAddress, string ccAddress, string bccAddresses, string subject, string textBody, string htmlBody, string contentType, string mergeContext);
    }
}