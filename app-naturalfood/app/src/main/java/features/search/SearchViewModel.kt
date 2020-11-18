package com.gsm.naturalfood.features.search

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.gsm.domain.features.places.Place
import com.gsm.domain.features.places.interactors.PlaceUseCase
import kotlinx.coroutines.flow.collect
import kotlinx.coroutines.launch
import java.lang.Exception

class SearchViewModel(private val placeUseCase: PlaceUseCase) : ViewModel() {

    val state = MutableLiveData<State>()

    fun getPlaces() {
        try {
            viewModelScope.launch {
                placeUseCase.getPlaces().collect {
                    state.value = State.OnSuccess(it)
                }
            }
        } catch (e: Exception) {
            e.printStackTrace()
        }
    }

    sealed class State {
        object OnLoading : State()
        data class OnSuccess(val places: List<Place>) : State()
        object OnError : State()
    }

}