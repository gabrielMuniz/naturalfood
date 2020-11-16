package com.gsm.data.features.base

object StatusCode {
    /**
     * Success Codes
     */
    const val SUCCESS = 200
    const val CREATED = 201
    const val NO_CONTENT = 204

    /**
     * Error Codes
     */
    const val BAD_REQUEST = 400
    const val UNAUTHORIZED = 401
    const val FORBIDDEN = 403
    const val INTERNAL_SERVER_ERROR = 500
    const val BAD_GATEWAY = 502
}