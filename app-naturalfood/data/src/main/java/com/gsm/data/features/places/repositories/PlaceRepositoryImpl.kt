package com.gsm.data.features.places.repositories

import com.gsm.data.features.places.datasource.contract.PlaceDataSource
import com.gsm.domain.features.places.Place
import com.gsm.domain.features.places.contracts.PlaceRepository
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.flow

class PlaceRepositoryImpl(private val placeDataSource: PlaceDataSource) : PlaceRepository {
    override suspend fun getPlaces(): Flow<List<Place>> = flow { emit(placeDataSource.getPlaces()) }
}