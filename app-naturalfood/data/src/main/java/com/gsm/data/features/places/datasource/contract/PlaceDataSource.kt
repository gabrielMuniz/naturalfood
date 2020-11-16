package com.gsm.data.features.places.datasource.contract

import com.gsm.domain.features.places.Place

interface PlaceDataSource {

    fun getPlaces(): List<Place>

}