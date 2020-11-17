package com.gsm.domain.features.places.contracts

import com.gsm.domain.features.places.Place
import kotlinx.coroutines.flow.Flow

interface PlaceRepository {

    suspend fun getPlaces(): Flow<List<Place>>

}