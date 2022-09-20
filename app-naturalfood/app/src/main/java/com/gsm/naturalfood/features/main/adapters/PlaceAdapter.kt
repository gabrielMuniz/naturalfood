package com.gsm.naturalfood.features.main.adapters

import android.content.Context
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.RatingBar
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.gsm.domain.features.places.Place
import com.gsm.naturalfood.R
import com.gsm.naturalfood.features.main.adapters.PlaceAdapter.PlaceViewHolder

class PlaceAdapter(private val context: Context, private val places: List<Place>) :
    RecyclerView.Adapter<PlaceViewHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int) =
        PlaceViewHolder(LayoutInflater.from(parent.context).inflate(viewType, parent, false))

    override fun getItemViewType(position: Int) = R.layout.item_place

    override fun onBindViewHolder(holder: PlaceViewHolder, position: Int) {
        val item = places[position]
        holder.tvName.text = item.name
        holder.tvAddress.text = item.address
        holder.ratingBar.rating = item.rating.toFloat()
    }

    override fun getItemCount() = places.size

    class PlaceViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
        val tvName: TextView = itemView.findViewById(R.id.tvName)
        val tvAddress: TextView = itemView.findViewById(R.id.tvAddress)
        val ratingBar: RatingBar = itemView.findViewById(R.id.rating)
    }

}