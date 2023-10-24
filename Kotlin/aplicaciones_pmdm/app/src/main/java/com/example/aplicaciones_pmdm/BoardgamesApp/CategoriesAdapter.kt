package com.example.aplicaciones_pmdm.BoardgamesApp

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView

class CategoriesAdapter (private val categories: List<GameCategory>): RecyclerView.Adapter<CategoriesViewHolder>
                    //RecyclerView.Adapter es un recyclerview de tipo adapter
{
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): CategoriesViewHolder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.item_game_category, parent, false)
        return CategoriesViewHolder(view)
    }


    override fun onBindViewHolder(holder: CategoriesViewHolder, position: Int) {
        holder.render(categories[position])
        //le pasas uno tantas veces como elementos haya en la lista
    }

    override fun getItemCount(): Int {
        return categories.size
    }
}