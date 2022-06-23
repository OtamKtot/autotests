package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Selenide.$;

public class TurnProject {
    SelenideElement radioButtonYes = $(".editor_radiobutton"),
            notificationContainer = $(".notification-body_container"),
            completeTask = $("[title=\"Завершить задачу\"]");

    @Step("Завершить задачу")
    public TurnProject CompleteTask() {
        radioButtonYes.click();
        completeTask.click();
        return this;
    }

    @Step("Задача завершена")
    public TurnProject OperationComplete() {
        notificationContainer.shouldHave(text("Операция выполнена"));
        return this;
    }
}
