package com.gsm.naturalfood.com.gsm.naturalfood.ui

import android.graphics.Color
import android.graphics.drawable.ColorDrawable
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.fragment.app.DialogFragment
import com.gsm.naturalfood.R

class LoadingDialog : DialogFragment() {

    override fun onStart() {
        super.onStart()
        dialog?.window?.setLayout(
            ViewGroup.LayoutParams.MATCH_PARENT,
            ViewGroup.LayoutParams.MATCH_PARENT
        )
    }

    override fun onCreateView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?): View? {
        super.onCreateView(inflater, container, savedInstanceState)
        val layout = inflater.inflate(R.layout.loading_layout, container)
        setStyle(STYLE_NORMAL, R.style.AppTheme_FullScreenDialog)
        layout.background = ColorDrawable(Color.TRANSPARENT)
        isCancelable = false
        return layout
    }

}