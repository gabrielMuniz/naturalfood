package com.gsm.naturalfood.di

import com.gsm.data.configuration.ApiClientBuilder
import com.gsm.data.core.RequestMakerImpl
import com.gsm.data.core.contracts.RequestMaker
import com.gsm.data.features.places.contracts.PlacesApi
import com.gsm.naturalfood.BuildConfig
import org.koin.dsl.module

val networkServiceModule = module {

    single {
        RequestMakerImpl()
    }

    single {
        ApiClientBuilder.createService(serviceClass = PlacesApi::class.java, baseUrl = BuildConfig.BASE_URL)
    }

}