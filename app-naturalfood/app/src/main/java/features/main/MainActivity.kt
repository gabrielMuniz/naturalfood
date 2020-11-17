package features.main

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.gsm.domain.features.places.Place
import com.gsm.naturalfood.R
import features.main.MainViewModel.State.OnError
import features.main.MainViewModel.State.OnLoading
import features.main.MainViewModel.State.OnSuccess
import features.main.adapters.PlaceAdapter
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    private val viewModel by viewModel(MainViewModel::class.java)

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        observeData()
    }

    private fun observeData() {
        viewModel.state.observe(this) { state ->
            when (state) {
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