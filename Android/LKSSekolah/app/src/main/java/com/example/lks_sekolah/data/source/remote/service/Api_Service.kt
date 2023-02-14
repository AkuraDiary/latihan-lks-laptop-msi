package com.example.lks_sekolah.data.source.remote.service


import androidx.lifecycle.LiveData
import com.example.lks_sekolah.data.source.remote.response.UserResponse
import retrofit2.Call
import retrofit2.http.Field
import retrofit2.http.FormUrlEncoded
import retrofit2.http.POST

interface Api_Service {

    @FormUrlEncoded
    @POST("user/user-login")
    fun loginUser(
        @Field("username") username : String,
        @Field("password") password : String,
    ) : Call<UserResponse>
}