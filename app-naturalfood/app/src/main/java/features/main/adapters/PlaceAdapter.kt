package features.main.adapters

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.gsm.domain.features.places.Place
import com.gsm.naturalfood.R
import features.main.adapters.PlaceAdapter.PlaceViewHolder
import kotlinx.android.synthetic.main.item_place.view.*

class PlaceAdapter(private val context: Context, private val places: List<Place>) :
    RecyclerView.Adapter<PlaceViewHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int) =
        PlaceViewHolder(LayoutInflater.from(parent.context).inflate(viewType, parent, false))

    override fun getItemViewType(position: Int) = R.layout.item_place

    override fun onBindViewHolder(holder: PlaceViewHolder, position: Int) {
        val item = places[position]
        holder.tvName.text = item.name
    }

    override fun getItemCount() = places.size

    class PlaceViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
        val tvName: TextView = itemView.findViewById(R.id.tvName)
    }

}