package com.example.lks_sekolah.data.source.remote

import com.example.lks_sekolah.data.source.remote.service.Api_Service
import okhttp3.OkHttpClient
import okhttp3.logging.HttpLoggingInterceptor
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import java.util.concurrent.TimeUnit

object RetrofitConfig {

    private val base_url = "http://10.213.3.247/sekolahapi/api/"
    private val http_client by lazy {
        OkHttpClient.Builder()
            .addInterceptor(HttpLoggingInterceptor().setLevel(HttpLoggingInterceptor.Level.BODY))
            .connectTimeout(1, TimeUnit.MINUTES)
            .readTimeout(1, TimeUnit.MINUTES)
            .build()
    }
    private val retrofitBuilder by lazy {
        Retrofit.Builder()
            .baseUrl(base_url)
            .client(http_client)
            .addConverterFactory(GsonConverterFactory.create())
    }

    val API_SERVICE = retrofitBuilder.build().create(Api_Service::class.java)
}
