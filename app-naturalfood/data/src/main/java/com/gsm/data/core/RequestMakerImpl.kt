package com.gsm.data.core

import com.gsm.data.core.contracts.RequestMaker
import com.gsm.data.features.base.ResponseBase
import retrofit2.Call
import retrofit2.awaitResponse

class RequestMakerImpl : RequestMaker {
    override suspend fun <T : Any> getResult(call: Call<T>): ResponseBase<T> {
        call.awaitResponse().let {
            return ResponseBase(it.body()!!, it.headers().toMultimap(), it.code())
        }
    }
}