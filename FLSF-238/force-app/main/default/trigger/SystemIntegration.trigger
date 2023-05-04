trigger IntegrateSystems on Account (after insert, after update) {
  // Integrate with NSDL for PAN
  if(Trigger.isInsert || Trigger.isUpdate) {
    Map<Id, Account> accountMap = new Map<Id, Account>();
    for(Account acc : Trigger.new) {
      // Check if PAN is empty
      if(acc.PAN__c == null) {
        accountMap.put(acc.Id, acc);
      }
    }
    
    if(!accountMap.isEmpty()) {
      // Call NSDL API to get PAN details
      List<PAN_Details__c> panDetailsList = NSDL_API.getPANDetails(accountMap.keyset());
      if(panDetailsList != null && !panDetailsList.isEmpty()) {
        // Update PAN details on Account
        for(PAN_Details__c panDetails : panDetailsList) {
          Account acc = accountMap.get(panDetails.AccountId__c);
          acc.PAN__c = panDetails.PAN__c;
        }
        update accountMap.values();
      }
    }
  }
  
  // Integrate with E-Feap for commission payment and channel management
  if(Trigger.isInsert || Trigger.isUpdate) {
    Map<Id, Account> accountMap = new Map<Id, Account>();
    for(Account acc : Trigger.new) {
      // Check if commission payment and channel management data is empty
      if(acc.Commission_Payment__c == null || acc.Channel_Management__c == null) {
        accountMap.put(acc.Id, acc);
      }
    }
    
    if(!accountMap.isEmpty()) {
      // Call E-Feap API to get commission payment and channel management data
      List<Commission_Channel_Details__c> commissionChannelDetailsList = EFeap_API.getCommissionChannelDetails(accountMap.keyset());
      if(commissionChannelDetailsList != null && !commissionChannelDetailsList.isEmpty()) {
        // Update commission payment and channel management data on Account
        for(Commission_Channel_Details__c commissionChannelDetails : commissionChannelDetailsList) {
          Account acc = accountMap.get(commissionChannelDetails.AccountId__c);
          acc.Commission_Payment__c = commissionChannelDetails.Commission_Payment__c;
          acc.Channel_Management__c = commissionChannelDetails.Channel_Management__c;
        }
        update accountMap.values();
      }
    }
  }
  
  // Integrate with Bank for NEFT Payment
  if(Trigger.isInsert || Trigger.isUpdate) {
    Map<Id, Account> accountMap = new Map<Id, Account>();
    for(Account acc : Trigger.new) {
      // Check if NEFT Payment is empty
      if(acc.NEFT_Payment__c == null) {
        accountMap.put(acc.Id, acc);
      }
    }
    
    if(!accountMap.isEmpty()) {
      // Call Bank API to get NEFT payment details
      List<NEFT_Details__c> neftDetailsList = Bank_API.getNEFTDetails(accountMap.keyset());
      if(neftDetailsList != null && !neftDetailsList.isEmpty()) {
        // Update NEFT Payment details on Account
        for(NEFT_Details__c neftDetails : neftDetailsList) {
          Account acc = accountMap.get(neftDetails.AccountId__c);
          acc.NEFT_Payment__c = neftDetails.NEFT_Payment__c;
        }
        update accountMap.values();
      }
    }
  }
  
  // Integrate with ONGC
  if(Trigger.isInsert || Trigger.isUpdate) {
    Map<Id, Account> accountMap = new Map<Id, Account>();
    for(Account acc : Trigger.new) {
      // Check if Data Exchange is empty
      if(acc.Data_Exchange__c == null) {
        accountMap.put(acc.Id, acc);
      }
    }
    
    if(!accountMap.isEmpty()) {
      // Call ONGC API to get data exchange details
      List<Data_Exchange_Details__c> dataExchangeDetailsList = ONGC_API.