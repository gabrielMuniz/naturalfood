package com.gsm.naturalfood.di

import com.gsm.domain.features.places.interactors.PlaceUseCase
import org.koin.dsl.module

val useCaseModule = module {

    factory { PlaceUseCase(get()) }

}