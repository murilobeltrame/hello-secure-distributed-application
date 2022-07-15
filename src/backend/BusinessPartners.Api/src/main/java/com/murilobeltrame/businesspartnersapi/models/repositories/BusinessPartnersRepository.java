package com.murilobeltrame.businesspartnersapi.models.repositories;

import com.murilobeltrame.businesspartnersapi.models.entities.BusinessPartner;
import org.springframework.data.repository.CrudRepository;

public interface BusinessPartnersRepository extends CrudRepository<BusinessPartner, Long> { }
