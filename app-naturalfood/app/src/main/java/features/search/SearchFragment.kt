package features.search

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import com.gsm.domain.features.places.Place
import com.gsm.naturalfood.R
import com.gsm.naturalfood.features.search.SearchViewModel
import features.main.MainViewModel
import features.main.adapters.PlaceAdapter
import kotlinx.android.synthetic.main.fragment_search.*
import org.koin.androidx.viewmodel.ext.android.viewModel

class SearchFragment : Fragment() {

    private val viewModel: SearchViewModel by viewModel()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        observeData()
        viewModel.getPlaces()
    }

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View? {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_search, container, false)
    }

    private fun observeData() {
        viewModel.state.observe(this) {
            when (it) {
                is SearchViewModel.State.OnSuccess -> {
                    loadAdapter(it.places)
                }
                SearchViewModel.State.OnLoading -> TODO()
                SearchViewModel.State.OnError -> TODO()
            }
        }
    }

    private fun loadAdapter(places: List<Place>) {
        rvPlaces.adapter = PlaceAdapter(context = context!!, places = places)
    }


}