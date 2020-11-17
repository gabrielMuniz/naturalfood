package com.gsm.data.features.places.contracts

import com.gsm.data.features.base.ResponseBase
import com.gsm.data.features.places.arguments.PlaceResponse
import retrofit2.Call
import retrofit2.http.GET

interface PlacesApi {

    @GET("places")
    fun getPlaces(): Call<List<PlaceResponse>>

}