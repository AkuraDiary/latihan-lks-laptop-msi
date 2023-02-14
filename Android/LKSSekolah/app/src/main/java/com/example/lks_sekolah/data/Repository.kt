package com.example.lks_sekolah.data

import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import com.example.lks_sekolah.data.source.remote.RetrofitConfig
import com.example.lks_sekolah.data.source.remote.response.UserResponse
import com.example.lks_sekolah.data.source.remote.service.Api_Service
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response


object Repository {
    private val _userResponse : MutableLiveData<UserResponse> = MutableLiveData()
    val userResponse : LiveData<UserResponse> = _userResponse


    fun doLogin(username : String, password: String){
        RetrofitConfig.API_SERVICE.loginUser(username, password).enqueue(object : Callback<UserResponse>{
            override fun onResponse(
                call: Call<UserResponse>,
                response: Response<UserResponse>
            ) {
                if (response.isSuccessful){
                    _userResponse.value = response.body()
                }
            }

            override fun onFailure(call: Call<UserResponse>, t: Throwable) {
                Log.d("USER LOGIN REPOSITORY", t.message.toString())
            }
        })
    }
}