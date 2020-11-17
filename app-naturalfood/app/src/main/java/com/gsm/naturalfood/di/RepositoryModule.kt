package com.gsm.naturalfood.di

import com.gsm.data.features.places.repositories.PlaceRepositoryImpl
import com.gsm.domain.features.places.contracts.PlaceRepository
import org.koin.dsl.module

val repositoryModule = module {
    
    factory { PlaceRepositoryImpl(get()) as PlaceRepository }

}