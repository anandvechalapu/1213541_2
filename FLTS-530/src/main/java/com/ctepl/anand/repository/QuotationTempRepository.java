package com.ctepl.anand.repository;

import com.ctepl.anand.entity.QuotationTemp;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface QuotationTempRepository extends JpaRepository<QuotationTemp, Long> {

    List<QuotationTemp> findByQuotationStatus(String quotationStatus);
}