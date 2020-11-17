package com.gsm.domain.features.places.interactors

import com.gsm.domain.features.places.Place
import com.gsm.domain.features.places.contracts.PlaceRepository
import kotlinx.coroutines.flow.Flow

class PlaceUseCase(private val placeRepository: PlaceRepository) {

    suspend fun getPlaces(): Flow<List<Place>> = placeRepository.getPlaces()

}