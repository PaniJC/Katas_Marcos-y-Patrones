class Marine
    attr_accessor :damage, :armor
    def initialize(damage, armor)
      @damage=damage
      @armor= armor
    end
  end
  
  class Marine_weapon_upgrade
    attr_reader :marine
    
    def initialize(marine)
      @marine = marine
    end
    
    def damage
      marine.damage + 1
    end
    
    def armor
      marine.armor
    end
  end
  
  class Marine_armor_upgrade
    attr_reader :marine
    
    def initialize(marine)
      @marine = marine
    end
    
    def armor
      marine.armor + 1 
    end
    
    def damage
      marine.damage
    end
  end