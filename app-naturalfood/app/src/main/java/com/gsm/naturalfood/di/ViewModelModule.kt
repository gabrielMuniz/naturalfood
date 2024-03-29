package com.gsm.naturalfood.di

import com.gsm.naturalfood.features.search.SearchViewModel
import com.gsm.naturalfood.features.main.MainViewModel
import org.koin.androidx.viewmodel.dsl.viewModel
import org.koin.dsl.module

val viewModelModule = module {

    viewModel { MainViewModel(get()) }
    viewModel { SearchViewModel(get()) }

}