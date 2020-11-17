package com.gsm.domain.features.places.contracts

import com.gsm.domain.features.places.Place

interface PlaceRepository {

    suspend fun getPlaces(): List<Place>

}