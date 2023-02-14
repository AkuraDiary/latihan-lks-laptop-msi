package com.example.lks_sekolah.data.source.preferences

import android.content.Context
import com.example.lks_sekolah.data.source.remote.response.UserResponse

class UserPreferences(mContext : Context) {

    companion object{
        val prefName = "usr_login"
        val id_key = "usr_id"
        val name_key = "usr_name"
    }

    private val preferences = mContext.getSharedPreferences(prefName, Context.MODE_PRIVATE)
    private val editor = preferences.edit()

    fun deleteSession(){
        editor.apply {
            clear()
            apply()
            commit()
        }
    }

    fun saveSession(name : String, id : String){
        editor.apply {
            putString(id_key, id)
            putString(name_key, name)
            apply()
            commit()
        }

    }


    fun getSession() : UserResponse? {
        val id = preferences.getString(id_key, "")
        val name = preferences.getString(name_key, "")
        return UserResponse(user_id = id, name = name)
    }
}