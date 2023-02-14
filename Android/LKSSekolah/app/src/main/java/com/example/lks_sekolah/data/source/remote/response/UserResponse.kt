package com.example.lks_sekolah.data.source.remote.response

import android.os.Parcelable
import kotlinx.parcelize.Parcelize

@Parcelize
data class UserResponse(
    var address: String? = null,
    var date_of_birth: String? = null,
    var gender: String?= null,
    var name: String?= null,
    var no_hp: String?= null,
    var password: String?= null,
    var photo: String?= null,
    var role_id: Int?= null,
    var user_id: String?= null,
    var username: String?= null
) : Parcelable