package com.example.lks_sekolah.data.source.remote.response

import android.os.Parcelable
import kotlinx.parcelize.Parcelize

@Parcelize
data class Subject(
    var assignment: Int?,
    var description: String?,
    var final_exam: Int?,
    var mid_exam: Int?,
    var name: String?,
    var subject_id: String?
) : Parcelable