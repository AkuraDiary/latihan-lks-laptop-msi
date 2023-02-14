package com.example.lks_sekolah.data.source.remote.response

import android.os.Parcelable
import kotlinx.parcelize.Parcelize

@Parcelize
data class HeaderScheduleResponseItem(
    var class_id: String?,
    var schedule_id: Int?,
    var subject_id: String?,
    var teacher_id: String?
) : Parcelable