package com.gsm.data.features.base

class ResponseBase<T>(val data: T, val header: MutableMap<String, List<String>>, val status: StatusCode)