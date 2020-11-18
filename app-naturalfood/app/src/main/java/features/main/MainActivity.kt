package features.main

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.gsm.naturalfood.R
import features.main.MainViewModel.State.OnError
import features.main.MainViewModel.State.OnLoading
import features.main.MainViewModel.State.OnSuccess
import features.search.SearchFragment
import kotlinx.android.synthetic.main.activity_main.bnMain
import org.koin.androidx.viewmodel.ext.android.viewModel

class MainActivity : AppCompatActivity() {

    private val viewModel: MainViewModel by viewModel()

    private val fragmentTransaction by lazy { supportFragmentManager.beginTransaction() }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        setupMenu()
        //viewModel.getPlaces()
    }

    private fun setupMenu() {
        bnMain.setOnNavigationItemSelectedListener {
            when (it.itemId) {
                R.id.searchItem -> {
                    fragmentTransaction.replace(R.id.frameContent, SearchFragment())
                    fragmentTransaction.commit()
                    true
                }
                else -> {
                    false
                }
            }
        }
    }

}