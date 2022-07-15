package com.murilobeltrame.businesspartnersapi.controllers;

import com.murilobeltrame.businesspartnersapi.models.entities.BusinessPartner;
import com.murilobeltrame.businesspartnersapi.models.repositories.BusinessPartnersRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.*;

import java.net.URI;

@RestController
@RequestMapping("/business-partners")
public class BusinessPartnersController {
    @Autowired
    private BusinessPartnersRepository businessPartnersRepository;

    @GetMapping
    public ResponseEntity<Iterable<BusinessPartner>> fetch() {
        var response = businessPartnersRepository.findAll();
        return ResponseEntity.ok().body(response);
    }

    @GetMapping("/{id}")
    public ResponseEntity<BusinessPartner> get(@PathVariable(value = "id")long id) {
        var businessPartner = businessPartnersRepository.findById(id);
        if (businessPartner.isPresent()) return ResponseEntity.ok().body(businessPartner.get());
        else return ResponseEntity.notFound().build();
    }

    @PostMapping
    public ResponseEntity<BusinessPartner> create(@Validated @RequestBody BusinessPartner businessPartner) {
        var result = businessPartnersRepository.save(businessPartner);
        return ResponseEntity.created(URI.create("/business-partners/" + result.getId())).body(result);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity delete(@PathVariable(value = "id")long id) {
        var businessPartner = businessPartnersRepository.findById(id);
        if (!businessPartner.isPresent()) return ResponseEntity.notFound().build();
        businessPartnersRepository.delete(businessPartner.get());
        return ResponseEntity.noContent().build();
    }
}
