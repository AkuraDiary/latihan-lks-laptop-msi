package com.example.lks_sekolah

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.example.lks_sekolah.data.Repository
import com.example.lks_sekolah.data.source.preferences.UserPreferences
import com.example.lks_sekolah.databinding.ActivityLoginBinding
import com.example.lks_sekolah.databinding.ActivityMainBinding

class LoginActivity : AppCompatActivity() {
    private var binding  : ActivityLoginBinding? = null
    private lateinit var userPreferences: UserPreferences
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        userPreferences = UserPreferences(applicationContext)
        binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding?.root)

        //check logged in user
        if (!(userPreferences.getSession())?.user_id.isNullOrEmpty()){
            moveTOMainActivity()
        }

        setupInput()
        observeLoginResult()
    }

    fun observeLoginResult(){
        Repository.userResponse.observe(this){
            if (it.user_id?.isNotEmpty()!!){
                userPreferences.saveSession(it.name!!, it.user_id!!)
                moveTOMainActivity()
            }
        }
    }
    fun setupInput(){

        binding?.btnLogin?.setOnClickListener{
            //DO LOGIN HERE
            if (formisvalid()){
                Repository.doLogin(
                    binding?.edtUsername?.text.toString(),
                    binding?.edtPassword?.text.toString()
                )
            }
        }
    }

    fun formisvalid() : Boolean{
        when{

            binding?.edtUsername?.text.isNullOrEmpty() -> {
                binding?.edtUsername!!.error = "Username tidak boleh kosong"
                return false
            }

            binding?.edtPassword?.text.isNullOrEmpty() -> {
                binding?.edtPassword!!.error = "Password tidak boleh kosong"
                return false
            }
            else -> {
                return true

            }
        }
    }

    fun moveTOMainActivity(){
        val intent = Intent(this@LoginActivity, MainActivity::class.java)
        startActivity(intent)
        finish()
    }

    override fun onDestroy() {
        super.onDestroy()
        binding = null
    }
}