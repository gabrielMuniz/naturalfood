package com.gsm.data.features.places.datasource.contract

import com.gsm.domain.features.places.Place

interface PlaceDataSource {

    suspend fun getPlaces(): List<Place>

}