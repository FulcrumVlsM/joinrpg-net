﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JoinRpg.Web.Models
{
  public abstract class EditGameObjectViewModelBase
  {
    public int ProjectId { get; set; }
    
    [ReadOnly(true)]
    public string ProjectName { get; set; }

    [Required, DisplayName("Является частью локаций")]
    public List<int> ParentCharacterGroupIds { get; set; } = new List<int>();

    [DisplayName("Публично?")]
    public bool IsPublic { get; set; } = true;

    [DataType(DataType.MultilineText),DisplayName("Описание")]
    public string Description { get; set; }

    [ReadOnly(true)]
    public CharacterGroupListViewModel Data { get; set; }

    public abstract IEnumerable<CharacterGroupListItemViewModel> PossibleParents { get; }
  }
}