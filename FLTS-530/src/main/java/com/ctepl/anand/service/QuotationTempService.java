package com.ctepl.anand.service;

import com.ctepl.anand.entity.QuotationTemp;
import com.ctepl.anand.repository.QuotationTempRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class QuotationTempService {

    @Autowired
    private QuotationTempRepository quotationTempRepository;

    public List<QuotationTemp> getQuotationsByStatus(String quotationStatus) {
        return quotationTempRepository.findByQuotationStatus(quotationStatus);
    }

}