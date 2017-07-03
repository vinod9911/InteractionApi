using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntractionApi.Models;

namespace IntractionApi.AppLogic
{
    public class AppSetData
    {
       public IList<SampleData> SetData()
        {
            IList<SampleData> sample = new List<SampleData>
                            { new SampleData { Id = 1,
                                               Name = "Test Data",
                                               Data = @"<pmq:Control>
                                                                                <pmq:ProcessQuoteDetail > true </ pmq:ProcessQuoteDetail >
    
                                                                                    < pmq:ProcessDocuments > true </ pmq:ProcessDocuments >
         
                                                                                         < pmq:ProcessEndorsements > true </ pmq:ProcessEndorsements >
              
                                                                                              < pmq:ProcessUseDetail > true </ pmq:ProcessUseDetail >
                   
                                                                                                   < pmq:ProcessUWNotes > true </ pmq:ProcessUWNotes >
                        
                                                                                                        < pmq:ProcessWarnings > true </ pmq:ProcessWarnings >
                             
                                                                                                             < pmq:ProcessPremiumBreakdown > true </ pmq:ProcessPremiumBreakdown >
                                  
                                                                                                                  < pmq:ProcessExcesses > true </ pmq:ProcessExcesses >
                                       
                                                                                                                       < pmq:LOB >
                                        
                                                                                                                                        < pmq:Description > PMC </ pmq:Description >
                                             
                                                                                                                                             < pmq:Abi > 1 </ pmq:Abi >
                                                  
                                                                                                                                  </ pmq:LOB >
                                                   
                                                                                                                                   < pmq:MaxQuoteNumber > 1 </ pmq:MaxQuoteNumber >
                                                        
                                                                                                                                        < pmq:QuotePanel >
                                                         
                                                                                                                                                         < pmq:Description > Broker Panel </ pmq:Description >
                                                              
                                                                                                                                                              < pmq:Abi > 2 </ pmq:Abi >
                                                                   
                                                                                                                                                   </ pmq:QuotePanel >
                                                                    
                                                                                                                                                    < pmq:Polaris > true </ pmq:Polaris >
                                                                         
                                                                                                                                                         < pmq:SingleCompany > true </ pmq:SingleCompany >
                                                                              
                                                                                                                                                              < pmq:SSP > true </ pmq:SSP >
                                                                                   
                                                                                                                                                                   < pmq:ExternalQuoteID > 1111 </ pmq:ExternalQuoteID >
                                                                                        
                                                                                                                                                                        < pmq:CreditControlConsent > true </ pmq:CreditControlConsent >
                                                                                             
                                                                                                                                                                             < pmq:SingleQuoteRequest >
                                                                                              
                                                                                                                                                                                              < pmq:QuoteMultipleBroker > false </ pmq:QuoteMultipleBroker >
                                                                                                   
                                                                                                                                                                                                   < pmq:BrokerSCIDs > A10459 </ pmq:BrokerSCIDs >
                                                                                                        
                                                                                                                                                                                        </ pmq:SingleQuoteRequest >
                                                                                                         
                                                                                                                                                                                         < pmq:TransactionType > NewBusiness </ pmq:TransactionType >
                                                                                                              
                                                                                                                                                                                              < pmq:ProcessSchemeData > true </ pmq:ProcessSchemeData >
                                                                                                                   
                                                                                                                                                                                                   < pmq:ProcessSections > true </ pmq:ProcessSections >
                                                                                                                        
                                                                                                                                                                                                        < pmq:ProcessSoftwareDetails > true </ pmq:ProcessSoftwareDetails >
                                                                                                                             
                                                                                                                                                                                                             < pmq:ProcessInsurerData > true </ pmq:ProcessInsurerData >
                                                                                                                                  
                                                                                                                                                                                                                  < pmq:ProcessDVLAData > true </ pmq:ProcessDVLAData >
                                                                                                                                       
                                                                                                                                                                                                                       < pmq:Software >
                                                                                                                                        
                                                                                                                                                                                                                                        < pmq:SoftwareSupplier > 5 </ pmq:SoftwareSupplier >
                                                                                                                                             
                                                                                                                                                                                                                             </ pmq:Software >
                                                                                                                                              
                                                                                                                                                                                                              </ pmq:Control > " } };
            return sample;
        }
    }
}