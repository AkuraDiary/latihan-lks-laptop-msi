package com.example.lks_sekolah.data.source.remote.response

import android.os.Parcelable
import kotlinx.parcelize.Parcelize

@Parcelize
data class UserResponse(
    var address: String?,
    var date_of_birth: String?,
    var gender: String?,
    var name: String?,
    var no_hp: String?,
    var password: String?,
    var photo: String?,
    var role_id: Int?,
    var user_id: String?,
    var username: String?
) : Parcelable