package com.example.lks_sekolah.data.source.remote.response

import android.os.Parcelable
import kotlinx.parcelize.Parcelize

@Parcelize
data class StudentMultiScheduleResponsesItem(
    var id: Int?,
    var schedule_id: Int?,
    var student_id: String?
) : Parcelable