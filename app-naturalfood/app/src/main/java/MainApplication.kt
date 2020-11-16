import android.app.Application
import com.gsm.naturalfood.di.*
import org.koin.android.ext.koin.androidContext
import org.koin.android.ext.koin.androidLogger
import org.koin.core.context.startKoin

class MainApplication : Application() {

    override fun onCreate() {
        super.onCreate()
        setupInjector()
    }

    private fun setupInjector() {
        startKoin {
            androidLogger()
            androidContext(this@MainApplication)
            modules(getModules())
        }
    }

    private fun getModules() = listOf(
        viewModelModule,
        useCaseModule,
        repositoryModule,
        dataSourceModule
    )

}