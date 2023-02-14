package com.example.lks_sekolah

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.example.lks_sekolah.data.source.preferences.UserPreferences
import com.example.lks_sekolah.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {

    private var binding : ActivityMainBinding? = null
    private lateinit var userPreferences: UserPreferences
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        userPreferences = UserPreferences(applicationContext)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding?.root)
        binding?.tvWellcome?.text = "Wellcome ${userPreferences.getSession()?.name}"
    }

    override fun onDestroy() {
        super.onDestroy()
        binding = null
    }
}