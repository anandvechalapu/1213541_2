package com.ctepl.anand.controller;

import com.ctepl.anand.entity.QuotationTemp;
import com.ctepl.anand.service.QuotationTempService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class QuotationTempController {

    @Autowired
    private QuotationTempService quotationTempService;

    @GetMapping("/quotations-by-status")
    public List<QuotationTemp> getQuotationsByStatus(@RequestParam String quotationStatus) {
        return quotationTempService.getQuotationsByStatus(quotationStatus);
    }

}