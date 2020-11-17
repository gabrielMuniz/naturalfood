package com.gsm.data.features.places.repositories

import com.gsm.data.features.places.datasource.contract.PlaceDataSource
import com.gsm.domain.features.places.Place
import com.gsm.domain.features.places.contracts.PlaceRepository

class PlaceRepositoryImpl(private val placeDataSource: PlaceDataSource) : PlaceRepository {
    override suspend fun getPlaces(): List<Place> = placeDataSource.getPlaces()
}