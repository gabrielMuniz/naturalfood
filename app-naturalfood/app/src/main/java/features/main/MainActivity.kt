package com.gsm.naturalfood.features.main

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.gsm.domain.features.places.Place
import com.gsm.naturalfood.R
import features.main.MainViewModel
import features.main.MainViewModel.State.OnError
import features.main.MainViewModel.State.OnLoading
import features.main.MainViewModel.State.OnSuccess
import features.main.adapters.PlaceAdapter
import kotlinx.android.synthetic.main.activity_main.*
import kotlinx.coroutines.GlobalScope
import kotlinx.coroutines.coroutineScope
import kotlinx.coroutines.launch
import org.koin.androidx.viewmodel.ext.android.getViewModel

class MainActivity : AppCompatActivity() {

    private val viewModel by lazy { getViewModel<MainViewModel>() }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        observeData()
        GlobalScope.launch { viewModel.getPlaces() }
    }

    private fun observeData() {
        viewModel.state.observe(this) {
            when (it) {
                is OnSuccess -> loadAdapter(it.places)
                OnLoading -> TODO()
                OnError -> TODO()
            }
        }
    }

    private fun loadAdapter(places: List<Place>) {
        rvPlaces.adapter = PlaceAdapter(context = this, places = places)
    }

}