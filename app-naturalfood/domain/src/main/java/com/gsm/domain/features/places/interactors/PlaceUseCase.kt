package com.gsm.domain.features.places.interactors

import com.gsm.domain.features.places.contracts.PlaceRepository

class PlaceUseCase(private val placeRepository: PlaceRepository) {

    suspend fun getPlaces() = placeRepository.getPlaces()

}