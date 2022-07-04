package ru.comindware.pages.PPM;

import com.codeborne.selenide.SelenideElement;
import io.qameta.allure.Step;
import ru.comindware.PlatformComponents;

import static com.codeborne.selenide.Condition.text;
import static com.codeborne.selenide.Selenide.$;
import static com.codeborne.selenide.Selenide.$x;

public class EstablishProject {
    PlatformComponents platformComponents = new PlatformComponents();
    SelenideElement notificationContainer = platformComponents.notificationContainer(),
            addNewRecordToCollection = platformComponents.addNewRecordToCollection(4),
            collectionField1 = platformComponents.collectionField(2, 2),
            collectionField2 = platformComponents.collectionField(3, 2),
            collectionField3 = platformComponents.collectionField(4, 2),
            collectionField4 = platformComponents.collectionField(5),
            collectionField5 = platformComponents.collectionField(6),
            collectionField6 = platformComponents.collectionField(7),
            collectionField7 = platformComponents.collectionField(8),
            textField = platformComponents.textField(7),
            verticalLayout = $x("//*[@class='layout__vertical-layout']"),
            oldDateTime = $(".day.old"),
            newDateTime = $(".day.new", 2),
            dropDown = platformComponents.dropDown(2),
            firstElementFromDropdown = $(".dd-list__i.selected"),
            completeTask = $("[title=\"Завершить задачу\"]");

    @Step("Заполнение формы и полей коллекции")
    public EstablishProject FillFormField(String nameProject, String codeProject, String fioDirector) {
        addNewRecordToCollection.click();
        collectionField1.click();
        textField.setValue(codeProject);
        verticalLayout.click();
        collectionField2.click();
        textField.setValue(nameProject);
        verticalLayout.click();
        collectionField3.click();
        dropDown.setValue(fioDirector);
        firstElementFromDropdown.click();
        collectionField4.click();
        oldDateTime.click();
        collectionField5.click();
        newDateTime.click();
        collectionField6.click();
        collectionField7.click();
        firstElementFromDropdown.click();
        verticalLayout.click();
        return this;
    }

    @Step("Завершить задачу")
    public EstablishProject CompleteTask() {
        completeTask.click();
        return this;
    }

    @Step("Задача завершена")
    public EstablishProject OperationComplete() {
        notificationContainer.shouldHave(text("Операция выполнена"));
        return this;
    }

}
