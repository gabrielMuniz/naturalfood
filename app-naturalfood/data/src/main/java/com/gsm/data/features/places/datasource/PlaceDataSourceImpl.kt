package com.gsm.data.features.places.datasource

import com.gsm.data.core.contracts.RequestMaker
import com.gsm.data.features.places.arguments.PlaceResponse
import com.gsm.data.features.places.contracts.PlacesApi
import com.gsm.data.features.places.datasource.contract.PlaceDataSource
import com.gsm.domain.features.places.Place

class PlaceDataSourceImpl(private val requestMaker: RequestMaker, private val placesApi: PlacesApi) : PlaceDataSource {
    override suspend fun getPlaces(): List<Place> {
        val call = placesApi.getPlaces()
        return requestMaker.getResult(call).data.map { it.toEntity() }
    }

    private fun PlaceResponse.toEntity(): Place {
        return Place(id = id, name = name, address = address, rating = rating)
    }

}