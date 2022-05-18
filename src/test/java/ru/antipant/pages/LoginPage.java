package ru.antipant.pages;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;

import static com.codeborne.selenide.Selenide.$;
import static com.codeborne.selenide.Selenide.open;

public class LoginPage {
    SelenideElement login = $("#username");
    SelenideElement password = $("#password");
    SelenideElement loginButton = $("#LoginButton");

    @Step("Логинимся под {username} с паролем {pass}")
    public LoginPage login(String username, String pass) {
        open("");
        login.setValue(username);
        password.setValue(pass);
        loginButton.click();
        return this;
    }

}
