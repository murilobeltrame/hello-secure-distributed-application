package com.murilobeltrame.businesspartnersapi.models.entities;

import javax.persistence.*;

@Entity
@Table(name = "business_partners")
public class BusinessPartner {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private long id;
    @Column
    private String name;

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
