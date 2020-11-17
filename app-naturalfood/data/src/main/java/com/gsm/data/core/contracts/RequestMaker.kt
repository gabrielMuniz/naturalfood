package com.gsm.data.core.contracts

import com.gsm.data.features.base.ResponseBase
import retrofit2.Call

interface RequestMaker {

    suspend fun <T : Any> getResult(call: Call<T>) : ResponseBase<T>

}