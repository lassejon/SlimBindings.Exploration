package com.example.mwphotobrowserwrapper

import kotlinx.coroutines.*
import okhttp3.OkHttpClient
import okhttp3.Request

class MWPhotoBrowserSdk {
    companion object {
        private val client = OkHttpClient()

        @JvmStatic
        fun getItemCount(): Int {
            val url = "https://jsonplaceholder.typicode.com/posts"
            var itemCount = 0
            runBlocking {
                val request = Request.Builder().url(url).build()
                val response = client.newCall(request).execute()
                val responseBody = response.body?.string()
                if (responseBody != null) {
                    itemCount = responseBody.split("userId").size - 1
                }
            }
            return itemCount
        }
    }
}
