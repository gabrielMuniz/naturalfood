package features.main

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import com.gsm.domain.features.places.Place
import com.gsm.domain.features.places.interactors.PlaceUseCase
import java.lang.Exception

class MainViewModel(private val placeUseCase: PlaceUseCase) : ViewModel() {

    val state = MutableLiveData<State>()

    suspend fun getPlaces() {
        try {
            placeUseCase.getPlaces()
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