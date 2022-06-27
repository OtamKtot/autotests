package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Selenide.$;
import static com.codeborne.selenide.Selenide.$x;

public class ApointDirector {
    SelenideElement notificationContainer = $(".notification-body_container"),
            addNewRecordToCollection = $x("(//*[@class='toolbar-btn toolbar-btn_none    toolbar-btn_action  '])[3]"),
            collectionField1 = $x("//*[@class='js-visible-collection visible-collection ']/tr/td[3]"),
            dropDown = $x("(//*[@class='js-input bubbles__input'])[4]"),
            firstListCheckBox = $x("//*[@class='dd-list__i dd-list__i_checkbox selected']"),
            completeTask = $("[title=\"Завершить\"]");

    @Step("Добавить руководителя в коллекцию")
    public ApointDirector FillFormField(String fioRukovoditel) {
        addNewRecordToCollection.click();
        collectionField1.click();
        dropDown.setValue(fioRukovoditel);
        firstListCheckBox.click();
        return this;
    }
    @Step("Завершить задачу")
    public ApointDirector CompleteTask() {
        completeTask.click();
        return this;
    }

    @Step("Задача завершена")
    public ApointDirector OperationComplete() {
        notificationContainer.shouldHave(text("Операция выполнена"));
        return this;
    }
}
