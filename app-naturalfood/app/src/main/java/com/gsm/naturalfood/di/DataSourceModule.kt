package com.gsm.naturalfood.di

import com.gsm.data.features.places.datasource.PlaceDataSourceImpl
import com.gsm.data.features.places.datasource.contract.PlaceDataSource
import org.koin.dsl.module

val dataSourceModule = module {

    factory { PlaceDataSourceImpl(get(), get()) as PlaceDataSource }

}