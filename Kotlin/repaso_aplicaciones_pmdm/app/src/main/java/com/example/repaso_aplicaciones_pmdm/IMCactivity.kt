package com.example.repaso_aplicaciones_pmdm

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import androidx.cardview.widget.CardView

class IMCactivity : AppCompatActivity() {

    private lateinit var viewMale: CardView
    private lateinit var viewFemale: CardView

    private var isMaleSelected: Boolean = true;
    private var isFemaleSelected: Boolean = false;

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.imc_activity)
        initComponentes()
        initListeners()
    }
    private fun initComponentes() {
        viewMale = findViewById<CardView>(R.id.viewMale)
        viewFemale = findViewById<CardView>(R.id.viewFemale)
    }
    private fun initListeners() {
        viewMale.setOnClickListener { setComponentColorMale() }
        viewFemale.setOnClickListener { }
    }

    private fun setComponentColorMale() {
        if (!isMaleSelected){
            viewMale.setCardBackgroundColor(getColor(R.color.background_component_selected))
            viewFemale.setCardBackgroundColor(getColor(R.color.background_component))
            isMaleSelected = true
            isFemaleSelected = false
        }
    }


}