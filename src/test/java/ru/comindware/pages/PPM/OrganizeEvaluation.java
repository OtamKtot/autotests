package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;
import ru.comindware.PlatformComponents;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Selenide.$;

public class OrganizeEvaluation {
    PlatformComponents platformComponents = new PlatformComponents();
    SelenideElement notificationContainer = platformComponents.notificationContainer(),
            completeTask = $("[title=\"Завершить задачу\"]");

    @Step("Завершить задачу")
    public OrganizeEvaluation CompleteTask() {
        completeTask.click();
        return this;
    }

    @Step("Задача завершена")
    public OrganizeEvaluation OperationComplete() {
        notificationContainer.shouldHave(text("Операция выполнена"));
        return this;
    }
}
